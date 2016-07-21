using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCircularLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCircularLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkCircularLayoutStrategy()
		{
			vtkCircularLayoutStrategy.MRClassNameKey = "class vtkCircularLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCircularLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCircularLayoutStrategy"));
		}

		public vtkCircularLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCircularLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCircularLayoutStrategy New()
		{
			vtkCircularLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCircularLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCircularLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCircularLayoutStrategy_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCircularLayoutStrategy_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCircularLayoutStrategy_Layout_03(HandleRef pThis);

		public override void Layout()
		{
			vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_Layout_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCircularLayoutStrategy_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCircularLayoutStrategy NewInstance()
		{
			vtkCircularLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCircularLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCircularLayoutStrategy_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCircularLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCircularLayoutStrategy vtkCircularLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCircularLayoutStrategy = (vtkCircularLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCircularLayoutStrategy.Register(null);
				}
			}
			return vtkCircularLayoutStrategy;
		}
	}
}
