using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPassThroughEdgeStrategy : vtkEdgeLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassThroughEdgeStrategy";

		public new static readonly string MRClassNameKey;

		static vtkPassThroughEdgeStrategy()
		{
			vtkPassThroughEdgeStrategy.MRClassNameKey = "class vtkPassThroughEdgeStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassThroughEdgeStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassThroughEdgeStrategy"));
		}

		public vtkPassThroughEdgeStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThroughEdgeStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassThroughEdgeStrategy New()
		{
			vtkPassThroughEdgeStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPassThroughEdgeStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThroughEdgeStrategy_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThroughEdgeStrategy_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassThroughEdgeStrategy_Layout_03(HandleRef pThis);

		public override void Layout()
		{
			vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_Layout_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThroughEdgeStrategy_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPassThroughEdgeStrategy NewInstance()
		{
			vtkPassThroughEdgeStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThroughEdgeStrategy_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassThroughEdgeStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkPassThroughEdgeStrategy vtkPassThroughEdgeStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassThroughEdgeStrategy = (vtkPassThroughEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassThroughEdgeStrategy.Register(null);
				}
			}
			return vtkPassThroughEdgeStrategy;
		}
	}
}
