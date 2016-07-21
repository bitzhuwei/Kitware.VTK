using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkNonMergingPointLocator : vtkPointLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkNonMergingPointLocator";

		public new static readonly string MRClassNameKey;

		static vtkNonMergingPointLocator()
		{
			vtkNonMergingPointLocator.MRClassNameKey = "class vtkNonMergingPointLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNonMergingPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNonMergingPointLocator"));
		}

		public vtkNonMergingPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkNonMergingPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNonMergingPointLocator New()
		{
			vtkNonMergingPointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNonMergingPointLocator.vtkNonMergingPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkNonMergingPointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkNonMergingPointLocator.vtkNonMergingPointLocator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkNonMergingPointLocator_InsertUniquePoint_01(HandleRef pThis, IntPtr x, ref long ptId);

		public override int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_InsertUniquePoint_01(base.GetCppThis(), x, ref ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkNonMergingPointLocator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkNonMergingPointLocator_IsInsertedPoint_03(HandleRef pThis, IntPtr arg0);

		public override long IsInsertedPoint(IntPtr arg0)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsInsertedPoint_03(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkNonMergingPointLocator_IsInsertedPoint_04(HandleRef pThis, double arg0, double arg1, double arg2);

		public override long IsInsertedPoint(double arg0, double arg1, double arg2)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsInsertedPoint_04(base.GetCppThis(), arg0, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkNonMergingPointLocator_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkNonMergingPointLocator.vtkNonMergingPointLocator_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkNonMergingPointLocator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkNonMergingPointLocator NewInstance()
		{
			vtkNonMergingPointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNonMergingPointLocator.vtkNonMergingPointLocator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkNonMergingPointLocator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNonMergingPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkNonMergingPointLocator vtkNonMergingPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNonMergingPointLocator.vtkNonMergingPointLocator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonMergingPointLocator = (vtkNonMergingPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonMergingPointLocator.Register(null);
				}
			}
			return vtkNonMergingPointLocator;
		}
	}
}
