using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCoincidentPoints : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCoincidentPoints";

		public new static readonly string MRClassNameKey;

		static vtkCoincidentPoints()
		{
			vtkCoincidentPoints.MRClassNameKey = "class vtkCoincidentPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCoincidentPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoincidentPoints"));
		}

		public vtkCoincidentPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCoincidentPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCoincidentPoints New()
		{
			vtkCoincidentPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCoincidentPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCoincidentPoints.vtkCoincidentPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCoincidentPoints_AddPoint_01(HandleRef pThis, long Id, IntPtr point);

		public void AddPoint(long Id, IntPtr point)
		{
			vtkCoincidentPoints.vtkCoincidentPoints_AddPoint_01(base.GetCppThis(), Id, point);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCoincidentPoints_Clear_02(HandleRef pThis);

		public void Clear()
		{
			vtkCoincidentPoints.vtkCoincidentPoints_Clear_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCoincidentPoints_GetCoincidentPointIds_03(HandleRef pThis, IntPtr point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdList GetCoincidentPointIds(IntPtr point)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_GetCoincidentPointIds_03(base.GetCppThis(), point, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCoincidentPoints_GetNextCoincidentPointIds_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdList GetNextCoincidentPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_GetNextCoincidentPointIds_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCoincidentPoints_InitTraversal_05(HandleRef pThis);

		public void InitTraversal()
		{
			vtkCoincidentPoints.vtkCoincidentPoints_InitTraversal_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCoincidentPoints_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCoincidentPoints.vtkCoincidentPoints_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCoincidentPoints_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCoincidentPoints.vtkCoincidentPoints_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCoincidentPoints_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCoincidentPoints NewInstance()
		{
			vtkCoincidentPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCoincidentPoints_RemoveNonCoincidentPoints_10(HandleRef pThis);

		public void RemoveNonCoincidentPoints()
		{
			vtkCoincidentPoints.vtkCoincidentPoints_RemoveNonCoincidentPoints_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCoincidentPoints_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCoincidentPoints SafeDownCast(vtkObjectBase o)
		{
			vtkCoincidentPoints vtkCoincidentPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCoincidentPoints.vtkCoincidentPoints_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoincidentPoints = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoincidentPoints.Register(null);
				}
			}
			return vtkCoincidentPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCoincidentPoints_SpiralPoints_12(long num, HandleRef offsets);

		public static void SpiralPoints(long num, vtkPoints offsets)
		{
			vtkCoincidentPoints.vtkCoincidentPoints_SpiralPoints_12(num, (offsets == null) ? default(HandleRef) : offsets.GetCppThis());
		}
	}
}
