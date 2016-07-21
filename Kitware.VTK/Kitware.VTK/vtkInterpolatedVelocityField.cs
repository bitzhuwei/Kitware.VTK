using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInterpolatedVelocityField : vtkAbstractInterpolatedVelocityField
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolatedVelocityField";

		public new static readonly string MRClassNameKey;

		static vtkInterpolatedVelocityField()
		{
			vtkInterpolatedVelocityField.MRClassNameKey = "class vtkInterpolatedVelocityField";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolatedVelocityField"));
		}

		public vtkInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInterpolatedVelocityField New()
		{
			vtkInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset);

		public override void AddDataSet(vtkDataSet dataset)
		{
			vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_AddDataSet_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInterpolatedVelocityField_FunctionValues_02(HandleRef pThis, IntPtr x, IntPtr f);

		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_FunctionValues_02(base.GetCppThis(), x, f);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInterpolatedVelocityField_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkInterpolatedVelocityField_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolatedVelocityField_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInterpolatedVelocityField NewInstance()
		{
			vtkInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolatedVelocityField_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolatedVelocityField vtkInterpolatedVelocityField = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolatedVelocityField = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolatedVelocityField.Register(null);
				}
			}
			return vtkInterpolatedVelocityField;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInterpolatedVelocityField_SetLastCellId_08(HandleRef pThis, long c, int dataindex);

		public override void SetLastCellId(long c, int dataindex)
		{
			vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_SetLastCellId_08(base.GetCppThis(), c, dataindex);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkInterpolatedVelocityField_SetLastCellId_09(HandleRef pThis, long c);

		public override void SetLastCellId(long c)
		{
			vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_SetLastCellId_09(base.GetCppThis(), c);
		}
	}
}
