using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPassThroughLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassThroughLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkPassThroughLayoutStrategy()
		{
			vtkPassThroughLayoutStrategy.MRClassNameKey = "class vtkPassThroughLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassThroughLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassThroughLayoutStrategy"));
		}

		public vtkPassThroughLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThroughLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassThroughLayoutStrategy New()
		{
			vtkPassThroughLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPassThroughLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassThroughLayoutStrategy_Initialize_01(HandleRef pThis);

		public override void Initialize()
		{
			vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_Initialize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThroughLayoutStrategy_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThroughLayoutStrategy_IsLayoutComplete_03(HandleRef pThis);

		public override int IsLayoutComplete()
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_IsLayoutComplete_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThroughLayoutStrategy_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassThroughLayoutStrategy_Layout_05(HandleRef pThis);

		public override void Layout()
		{
			vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_Layout_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThroughLayoutStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPassThroughLayoutStrategy NewInstance()
		{
			vtkPassThroughLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThroughLayoutStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassThroughLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkPassThroughLayoutStrategy vtkPassThroughLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassThroughLayoutStrategy = (vtkPassThroughLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassThroughLayoutStrategy.Register(null);
				}
			}
			return vtkPassThroughLayoutStrategy;
		}
	}
}
