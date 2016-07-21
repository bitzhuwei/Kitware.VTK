using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPieceScalars : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPieceScalars";

		public new static readonly string MRClassNameKey;

		static vtkPieceScalars()
		{
			vtkPieceScalars.MRClassNameKey = "class vtkPieceScalars";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPieceScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPieceScalars"));
		}

		public vtkPieceScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPieceScalars New()
		{
			vtkPieceScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceScalars.vtkPieceScalars_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPieceScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPieceScalars.vtkPieceScalars_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceScalars_GetRandomMode_01(HandleRef pThis);

		public virtual int GetRandomMode()
		{
			return vtkPieceScalars.vtkPieceScalars_GetRandomMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceScalars_GetScalarMode_02(HandleRef pThis);

		public int GetScalarMode()
		{
			return vtkPieceScalars.vtkPieceScalars_GetScalarMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceScalars_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPieceScalars.vtkPieceScalars_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceScalars_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPieceScalars.vtkPieceScalars_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceScalars_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPieceScalars NewInstance()
		{
			vtkPieceScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceScalars.vtkPieceScalars_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceScalars_RandomModeOff_07(HandleRef pThis);

		public virtual void RandomModeOff()
		{
			vtkPieceScalars.vtkPieceScalars_RandomModeOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceScalars_RandomModeOn_08(HandleRef pThis);

		public virtual void RandomModeOn()
		{
			vtkPieceScalars.vtkPieceScalars_RandomModeOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceScalars_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPieceScalars SafeDownCast(vtkObjectBase o)
		{
			vtkPieceScalars vtkPieceScalars = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceScalars.vtkPieceScalars_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPieceScalars = (vtkPieceScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPieceScalars.Register(null);
				}
			}
			return vtkPieceScalars;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceScalars_SetRandomMode_10(HandleRef pThis, int _arg);

		public virtual void SetRandomMode(int _arg)
		{
			vtkPieceScalars.vtkPieceScalars_SetRandomMode_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceScalars_SetScalarModeToCellData_11(HandleRef pThis);

		public void SetScalarModeToCellData()
		{
			vtkPieceScalars.vtkPieceScalars_SetScalarModeToCellData_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceScalars_SetScalarModeToPointData_12(HandleRef pThis);

		public void SetScalarModeToPointData()
		{
			vtkPieceScalars.vtkPieceScalars_SetScalarModeToPointData_12(base.GetCppThis());
		}
	}
}
