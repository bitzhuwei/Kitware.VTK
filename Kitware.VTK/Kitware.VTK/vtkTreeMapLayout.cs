using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeMapLayout : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapLayout";

		public new static readonly string MRClassNameKey;

		static vtkTreeMapLayout()
		{
			vtkTreeMapLayout.MRClassNameKey = "class vtkTreeMapLayout";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapLayout"));
		}

		public vtkTreeMapLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeMapLayout New()
		{
			vtkTreeMapLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeMapLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeMapLayout.vtkTreeMapLayout_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkTreeMapLayout_FindVertex_01(HandleRef pThis, IntPtr pnt, IntPtr binfo);

		public long FindVertex(IntPtr pnt, IntPtr binfo)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_FindVertex_01(base.GetCppThis(), pnt, binfo);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapLayout_GetBoundingBox_02(HandleRef pThis, long id, IntPtr binfo);

		public void GetBoundingBox(long id, IntPtr binfo)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_GetBoundingBox_02(base.GetCppThis(), id, binfo);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapLayout_GetLayoutStrategy_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTreeMapLayoutStrategy GetLayoutStrategy()
		{
			vtkTreeMapLayoutStrategy vtkTreeMapLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_GetLayoutStrategy_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayoutStrategy = (vtkTreeMapLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayoutStrategy.Register(null);
				}
			}
			return vtkTreeMapLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern uint vtkTreeMapLayout_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapLayout_GetRectanglesFieldName_05(HandleRef pThis);

		public virtual string GetRectanglesFieldName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeMapLayout.vtkTreeMapLayout_GetRectanglesFieldName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeMapLayout_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeMapLayout_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapLayout_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeMapLayout NewInstance()
		{
			vtkTreeMapLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapLayout_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeMapLayout SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapLayout vtkTreeMapLayout = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayout = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayout.Register(null);
				}
			}
			return vtkTreeMapLayout;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapLayout_SetLayoutStrategy_11(HandleRef pThis, HandleRef strategy);

		public void SetLayoutStrategy(vtkTreeMapLayoutStrategy strategy)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_SetLayoutStrategy_11(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapLayout_SetRectanglesFieldName_12(HandleRef pThis, string _arg);

		public virtual void SetRectanglesFieldName(string _arg)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_SetRectanglesFieldName_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapLayout_SetSizeArrayName_13(HandleRef pThis, string name);

		public virtual void SetSizeArrayName(string name)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_SetSizeArrayName_13(base.GetCppThis(), name);
		}
	}
}
