using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkShaderProgram : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShaderProgram";

		public new static readonly string MRClassNameKey;

		static vtkShaderProgram()
		{
			vtkShaderProgram.MRClassNameKey = "class vtkShaderProgram";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShaderProgram.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShaderProgram"));
		}

		public vtkShaderProgram(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShaderProgram_AddShader_01(HandleRef pThis, HandleRef shader);

		public int AddShader(vtkShader shader)
		{
			return vtkShaderProgram.vtkShaderProgram_AddShader_01(base.GetCppThis(), (shader == null) ? default(HandleRef) : shader.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_AddShaderVariable_02(HandleRef pThis, string name, int numVars, IntPtr x);

		public virtual void AddShaderVariable(string name, int numVars, IntPtr x)
		{
			vtkShaderProgram.vtkShaderProgram_AddShaderVariable_02(base.GetCppThis(), name, numVars, x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderProgram_CreateShaderProgram_03(int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkShaderProgram CreateShaderProgram(int type)
		{
			vtkShaderProgram vtkShaderProgram = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_CreateShaderProgram_03(type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProgram = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProgram.Register(null);
				}
			}
			return vtkShaderProgram;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderProgram_GetMaterial_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXMLMaterial GetMaterial()
		{
			vtkXMLMaterial vtkXMLMaterial = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_GetMaterial_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMaterial = (vtkXMLMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMaterial.Register(null);
				}
			}
			return vtkXMLMaterial;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShaderProgram_GetNumberOfShaders_05(HandleRef pThis);

		public int GetNumberOfShaders()
		{
			return vtkShaderProgram.vtkShaderProgram_GetNumberOfShaders_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderProgram_GetShaderDeviceAdapter_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkShaderDeviceAdapter GetShaderDeviceAdapter()
		{
			vtkShaderDeviceAdapter vtkShaderDeviceAdapter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_GetShaderDeviceAdapter_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderDeviceAdapter = (vtkShaderDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderDeviceAdapter.Register(null);
				}
			}
			return vtkShaderDeviceAdapter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShaderProgram_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShaderProgram.vtkShaderProgram_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShaderProgram_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShaderProgram.vtkShaderProgram_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderProgram_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShaderProgram NewInstance()
		{
			vtkShaderProgram result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderProgram_NewShaderIterator_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCollectionIterator NewShaderIterator()
		{
			vtkCollectionIterator vtkCollectionIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_NewShaderIterator_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectionIterator = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectionIterator.Register(null);
				}
			}
			return vtkCollectionIterator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_PostRender_11(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void PostRender(vtkActor arg0, vtkRenderer arg1)
		{
			vtkShaderProgram.vtkShaderProgram_PostRender_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_ReadMaterial_12(HandleRef pThis);

		public virtual void ReadMaterial()
		{
			vtkShaderProgram.vtkShaderProgram_ReadMaterial_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkShaderProgram.vtkShaderProgram_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_RemoveShader_14(HandleRef pThis, int index);

		public void RemoveShader(int index)
		{
			vtkShaderProgram.vtkShaderProgram_RemoveShader_14(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_RemoveShader_15(HandleRef pThis, HandleRef shader);

		public void RemoveShader(vtkShader shader)
		{
			vtkShaderProgram.vtkShaderProgram_RemoveShader_15(base.GetCppThis(), (shader == null) ? default(HandleRef) : shader.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_Render_16(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void Render(vtkActor arg0, vtkRenderer arg1)
		{
			vtkShaderProgram.vtkShaderProgram_Render_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderProgram_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShaderProgram SafeDownCast(vtkObjectBase o)
		{
			vtkShaderProgram vtkShaderProgram = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderProgram.vtkShaderProgram_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProgram = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProgram.Register(null);
				}
			}
			return vtkShaderProgram;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderProgram_SetMaterial_18(HandleRef pThis, HandleRef arg0);

		public virtual void SetMaterial(vtkXMLMaterial arg0)
		{
			vtkShaderProgram.vtkShaderProgram_SetMaterial_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
