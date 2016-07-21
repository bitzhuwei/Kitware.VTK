using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkShader : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShader";

		public new static readonly string MRClassNameKey;

		static vtkShader()
		{
			vtkShader.MRClassNameKey = "class vtkShader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShader"));
		}

		public vtkShader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShader_AddShaderVariable_01(HandleRef pThis, string name, int num_of_elements, IntPtr values);

		public void AddShaderVariable(string name, int num_of_elements, IntPtr values)
		{
			vtkShader.vtkShader_AddShaderVariable_01(base.GetCppThis(), name, num_of_elements, values);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShader_Bind_02(HandleRef pThis);

		public virtual void Bind()
		{
			vtkShader.vtkShader_Bind_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_Compile_03(HandleRef pThis);

		public virtual int Compile()
		{
			return vtkShader.vtkShader_Compile_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_GetScope_04(HandleRef pThis);

		public int GetScope()
		{
			return vtkShader.vtkShader_GetScope_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_GetShaderVariable_05(HandleRef pThis, string name, IntPtr values);

		public int GetShaderVariable(string name, IntPtr values)
		{
			return vtkShader.vtkShader_GetShaderVariable_05(base.GetCppThis(), name, values);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_GetShaderVariableSize_06(HandleRef pThis, string name);

		public int GetShaderVariableSize(string name)
		{
			return vtkShader.vtkShader_GetShaderVariableSize_06(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_GetShaderVariableType_07(HandleRef pThis, string name);

		public int GetShaderVariableType(string name)
		{
			return vtkShader.vtkShader_GetShaderVariableType_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShader_GetXMLShader_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXMLShader GetXMLShader()
		{
			vtkXMLShader vtkXMLShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShader.vtkShader_GetXMLShader_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLShader = (vtkXMLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLShader.Register(null);
				}
			}
			return vtkXMLShader;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_HasShaderVariable_09(HandleRef pThis, string name);

		public int HasShaderVariable(string name)
		{
			return vtkShader.vtkShader_HasShaderVariable_09(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShader.vtkShader_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShader_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShader.vtkShader_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShader NewInstance()
		{
			vtkShader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShader.vtkShader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShader_PassShaderVariables_13(HandleRef pThis, HandleRef actor, HandleRef ren);

		public virtual void PassShaderVariables(vtkActor actor, vtkRenderer ren)
		{
			vtkShader.vtkShader_PassShaderVariables_13(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShader_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkShader.vtkShader_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShader SafeDownCast(vtkObjectBase o)
		{
			vtkShader vtkShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShader.vtkShader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShader = (vtkShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShader.Register(null);
				}
			}
			return vtkShader;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShader_SetXMLShader_16(HandleRef pThis, HandleRef arg0);

		public void SetXMLShader(vtkXMLShader arg0)
		{
			vtkShader.vtkShader_SetXMLShader_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShader_Unbind_17(HandleRef pThis);

		public virtual void Unbind()
		{
			vtkShader.vtkShader_Unbind_17(base.GetCppThis());
		}
	}
}
