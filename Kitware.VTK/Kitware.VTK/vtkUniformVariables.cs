using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUniformVariables : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniformVariables";

		public new static readonly string MRClassNameKey;

		static vtkUniformVariables()
		{
			vtkUniformVariables.MRClassNameKey = "class vtkUniformVariables";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniformVariables.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformVariables"));
		}

		public vtkUniformVariables(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformVariables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUniformVariables New()
		{
			vtkUniformVariables result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformVariables.vtkUniformVariables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUniformVariables() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUniformVariables.vtkUniformVariables_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_DeepCopy_01(HandleRef pThis, HandleRef other);

		public void DeepCopy(vtkUniformVariables other)
		{
			vtkUniformVariables.vtkUniformVariables_DeepCopy_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformVariables_GetCurrentName_02(HandleRef pThis);

		public string GetCurrentName()
		{
			return Marshal.PtrToStringAnsi(vtkUniformVariables.vtkUniformVariables_GetCurrentName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkUniformVariables_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUniformVariables.vtkUniformVariables_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkUniformVariables_IsAtEnd_04(HandleRef pThis);

		public bool IsAtEnd()
		{
			return vtkUniformVariables.vtkUniformVariables_IsAtEnd_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkUniformVariables_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUniformVariables.vtkUniformVariables_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_Merge_06(HandleRef pThis, HandleRef other);

		public void Merge(vtkUniformVariables other)
		{
			vtkUniformVariables.vtkUniformVariables_Merge_06(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformVariables_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUniformVariables NewInstance()
		{
			vtkUniformVariables result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformVariables.vtkUniformVariables_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_Next_09(HandleRef pThis);

		public void Next()
		{
			vtkUniformVariables.vtkUniformVariables_Next_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_RemoveAllUniforms_10(HandleRef pThis);

		public void RemoveAllUniforms()
		{
			vtkUniformVariables.vtkUniformVariables_RemoveAllUniforms_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_RemoveUniform_11(HandleRef pThis, string name);

		public void RemoveUniform(string name)
		{
			vtkUniformVariables.vtkUniformVariables_RemoveUniform_11(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformVariables_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUniformVariables SafeDownCast(vtkObjectBase o)
		{
			vtkUniformVariables vtkUniformVariables = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformVariables.vtkUniformVariables_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformVariables = (vtkUniformVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformVariables.Register(null);
				}
			}
			return vtkUniformVariables;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_Send_13(HandleRef pThis, string name, int uniformIndex);

		public void Send(string name, int uniformIndex)
		{
			vtkUniformVariables.vtkUniformVariables_Send_13(base.GetCppThis(), name, uniformIndex);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_SendCurrentUniform_14(HandleRef pThis, int uniformIndex);

		public void SendCurrentUniform(int uniformIndex)
		{
			vtkUniformVariables.vtkUniformVariables_SendCurrentUniform_14(base.GetCppThis(), uniformIndex);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_SetUniformMatrix_15(HandleRef pThis, string name, int rows, int columns, IntPtr value);

		public void SetUniformMatrix(string name, int rows, int columns, IntPtr value)
		{
			vtkUniformVariables.vtkUniformVariables_SetUniformMatrix_15(base.GetCppThis(), name, rows, columns, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_SetUniformf_16(HandleRef pThis, string name, int numberOfComponents, IntPtr value);

		public void SetUniformf(string name, int numberOfComponents, IntPtr value)
		{
			vtkUniformVariables.vtkUniformVariables_SetUniformf_16(base.GetCppThis(), name, numberOfComponents, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_SetUniformfv_17(HandleRef pThis, string name, int numberOfComponents, int numberOfElements, IntPtr value);

		public void SetUniformfv(string name, int numberOfComponents, int numberOfElements, IntPtr value)
		{
			vtkUniformVariables.vtkUniformVariables_SetUniformfv_17(base.GetCppThis(), name, numberOfComponents, numberOfElements, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_SetUniformi_18(HandleRef pThis, string name, int numberOfComponents, IntPtr value);

		public void SetUniformi(string name, int numberOfComponents, IntPtr value)
		{
			vtkUniformVariables.vtkUniformVariables_SetUniformi_18(base.GetCppThis(), name, numberOfComponents, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_SetUniformiv_19(HandleRef pThis, string name, int numberOfComponents, int numberOfElements, IntPtr value);

		public void SetUniformiv(string name, int numberOfComponents, int numberOfElements, IntPtr value)
		{
			vtkUniformVariables.vtkUniformVariables_SetUniformiv_19(base.GetCppThis(), name, numberOfComponents, numberOfElements, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkUniformVariables_Start_20(HandleRef pThis);

		public void Start()
		{
			vtkUniformVariables.vtkUniformVariables_Start_20(base.GetCppThis());
		}
	}
}
