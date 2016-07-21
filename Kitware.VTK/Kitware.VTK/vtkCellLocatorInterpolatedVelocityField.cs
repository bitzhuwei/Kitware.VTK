using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellLocatorInterpolatedVelocityField : vtkAbstractInterpolatedVelocityField
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellLocatorInterpolatedVelocityField";

		public new static readonly string MRClassNameKey;

		static vtkCellLocatorInterpolatedVelocityField()
		{
			vtkCellLocatorInterpolatedVelocityField.MRClassNameKey = "class vtkCellLocatorInterpolatedVelocityField";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellLocatorInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLocatorInterpolatedVelocityField"));
		}

		public vtkCellLocatorInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellLocatorInterpolatedVelocityField New()
		{
			vtkCellLocatorInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellLocatorInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellLocatorInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset);

		public override void AddDataSet(vtkDataSet dataset)
		{
			vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_AddDataSet_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellLocatorInterpolatedVelocityField_CopyParameters_02(HandleRef pThis, HandleRef from);

		public override void CopyParameters(vtkAbstractInterpolatedVelocityField from)
		{
			vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_CopyParameters_02(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellLocatorInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr f);

		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_FunctionValues_03(base.GetCppThis(), x, f);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_GetCellLocatorPrototype_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractCellLocator GetCellLocatorPrototype()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_GetCellLocatorPrototype_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_GetLastCellLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractCellLocator GetLastCellLocator()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_GetLastCellLocator_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellLocatorInterpolatedVelocityField_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellLocatorInterpolatedVelocityField_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellLocatorInterpolatedVelocityField NewInstance()
		{
			vtkCellLocatorInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellLocatorInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkCellLocatorInterpolatedVelocityField vtkCellLocatorInterpolatedVelocityField = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLocatorInterpolatedVelocityField = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLocatorInterpolatedVelocityField.Register(null);
				}
			}
			return vtkCellLocatorInterpolatedVelocityField;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellLocatorInterpolatedVelocityField_SetCellLocatorPrototype_11(HandleRef pThis, HandleRef prototype);

		public void SetCellLocatorPrototype(vtkAbstractCellLocator prototype)
		{
			vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_SetCellLocatorPrototype_11(base.GetCppThis(), (prototype == null) ? default(HandleRef) : prototype.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellLocatorInterpolatedVelocityField_SetLastCellId_12(HandleRef pThis, long c, int dataindex);

		public override void SetLastCellId(long c, int dataindex)
		{
			vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_SetLastCellId_12(base.GetCppThis(), c, dataindex);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellLocatorInterpolatedVelocityField_SetLastCellId_13(HandleRef pThis, long c);

		public override void SetLastCellId(long c)
		{
			vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_SetLastCellId_13(base.GetCppThis(), c);
		}
	}
}
