using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArcParallelEdgeStrategy : vtkEdgeLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArcParallelEdgeStrategy";

		public new static readonly string MRClassNameKey;

		static vtkArcParallelEdgeStrategy()
		{
			vtkArcParallelEdgeStrategy.MRClassNameKey = "class vtkArcParallelEdgeStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArcParallelEdgeStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcParallelEdgeStrategy"));
		}

		public vtkArcParallelEdgeStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArcParallelEdgeStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArcParallelEdgeStrategy New()
		{
			vtkArcParallelEdgeStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcParallelEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArcParallelEdgeStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArcParallelEdgeStrategy_GetNumberOfSubdivisions_01(HandleRef pThis);

		public virtual int GetNumberOfSubdivisions()
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_GetNumberOfSubdivisions_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArcParallelEdgeStrategy_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArcParallelEdgeStrategy_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkArcParallelEdgeStrategy_Layout_04(HandleRef pThis);

		public override void Layout()
		{
			vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_Layout_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArcParallelEdgeStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArcParallelEdgeStrategy NewInstance()
		{
			vtkArcParallelEdgeStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcParallelEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArcParallelEdgeStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArcParallelEdgeStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkArcParallelEdgeStrategy vtkArcParallelEdgeStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArcParallelEdgeStrategy = (vtkArcParallelEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArcParallelEdgeStrategy.Register(null);
				}
			}
			return vtkArcParallelEdgeStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkArcParallelEdgeStrategy_SetNumberOfSubdivisions_08(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_SetNumberOfSubdivisions_08(base.GetCppThis(), _arg);
		}
	}
}
