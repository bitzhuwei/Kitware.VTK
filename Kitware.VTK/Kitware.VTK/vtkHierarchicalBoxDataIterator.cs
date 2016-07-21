using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalBoxDataIterator : vtkCompositeDataIterator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBoxDataIterator";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalBoxDataIterator()
		{
			vtkHierarchicalBoxDataIterator.MRClassNameKey = "class vtkHierarchicalBoxDataIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalBoxDataIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBoxDataIterator"));
		}

		public vtkHierarchicalBoxDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataIterator New()
		{
			vtkHierarchicalBoxDataIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalBoxDataIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkHierarchicalBoxDataIterator_GetCurrentIndex_01(HandleRef pThis);

		public uint GetCurrentIndex()
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_GetCurrentIndex_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkHierarchicalBoxDataIterator_GetCurrentLevel_02(HandleRef pThis);

		public uint GetCurrentLevel()
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_GetCurrentLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataIterator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataIterator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataIterator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalBoxDataIterator NewInstance()
		{
			vtkHierarchicalBoxDataIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataIterator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataIterator SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalBoxDataIterator vtkHierarchicalBoxDataIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataIterator = (vtkHierarchicalBoxDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataIterator.Register(null);
				}
			}
			return vtkHierarchicalBoxDataIterator;
		}
	}
}
