using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVectorNorm : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVectorNorm";

		public new static readonly string MRClassNameKey;

		static vtkVectorNorm()
		{
			vtkVectorNorm.MRClassNameKey = "class vtkVectorNorm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVectorNorm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorNorm"));
		}

		public vtkVectorNorm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorNorm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVectorNorm New()
		{
			vtkVectorNorm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVectorNorm.vtkVectorNorm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVectorNorm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVectorNorm.vtkVectorNorm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVectorNorm_GetAttributeMode_01(HandleRef pThis);

		public virtual int GetAttributeMode()
		{
			return vtkVectorNorm.vtkVectorNorm_GetAttributeMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorNorm_GetAttributeModeAsString_02(HandleRef pThis);

		public string GetAttributeModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkVectorNorm.vtkVectorNorm_GetAttributeModeAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVectorNorm_GetNormalize_03(HandleRef pThis);

		public virtual int GetNormalize()
		{
			return vtkVectorNorm.vtkVectorNorm_GetNormalize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVectorNorm_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVectorNorm.vtkVectorNorm_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVectorNorm_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVectorNorm.vtkVectorNorm_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorNorm_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVectorNorm NewInstance()
		{
			vtkVectorNorm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVectorNorm.vtkVectorNorm_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVectorNorm_NormalizeOff_08(HandleRef pThis);

		public virtual void NormalizeOff()
		{
			vtkVectorNorm.vtkVectorNorm_NormalizeOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVectorNorm_NormalizeOn_09(HandleRef pThis);

		public virtual void NormalizeOn()
		{
			vtkVectorNorm.vtkVectorNorm_NormalizeOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorNorm_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVectorNorm SafeDownCast(vtkObjectBase o)
		{
			vtkVectorNorm vtkVectorNorm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVectorNorm.vtkVectorNorm_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVectorNorm = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVectorNorm.Register(null);
				}
			}
			return vtkVectorNorm;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVectorNorm_SetAttributeMode_11(HandleRef pThis, int _arg);

		public virtual void SetAttributeMode(int _arg)
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeMode_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVectorNorm_SetAttributeModeToDefault_12(HandleRef pThis);

		public void SetAttributeModeToDefault()
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeModeToDefault_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVectorNorm_SetAttributeModeToUseCellData_13(HandleRef pThis);

		public void SetAttributeModeToUseCellData()
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeModeToUseCellData_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVectorNorm_SetAttributeModeToUsePointData_14(HandleRef pThis);

		public void SetAttributeModeToUsePointData()
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeModeToUsePointData_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVectorNorm_SetNormalize_15(HandleRef pThis, int _arg);

		public virtual void SetNormalize(int _arg)
		{
			vtkVectorNorm.vtkVectorNorm_SetNormalize_15(base.GetCppThis(), _arg);
		}
	}
}
