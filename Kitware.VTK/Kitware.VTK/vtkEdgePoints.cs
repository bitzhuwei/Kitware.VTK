using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEdgePoints : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgePoints";

		public new static readonly string MRClassNameKey;

		static vtkEdgePoints()
		{
			vtkEdgePoints.MRClassNameKey = "class vtkEdgePoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgePoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgePoints"));
		}

		public vtkEdgePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgePoints New()
		{
			vtkEdgePoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgePoints.vtkEdgePoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEdgePoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEdgePoints.vtkEdgePoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEdgePoints_GetValue_01(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkEdgePoints.vtkEdgePoints_GetValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEdgePoints_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEdgePoints.vtkEdgePoints_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEdgePoints_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEdgePoints.vtkEdgePoints_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgePoints_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEdgePoints NewInstance()
		{
			vtkEdgePoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgePoints.vtkEdgePoints_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgePoints_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgePoints SafeDownCast(vtkObjectBase o)
		{
			vtkEdgePoints vtkEdgePoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgePoints.vtkEdgePoints_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgePoints = (vtkEdgePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgePoints.Register(null);
				}
			}
			return vtkEdgePoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEdgePoints_SetValue_07(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkEdgePoints.vtkEdgePoints_SetValue_07(base.GetCppThis(), _arg);
		}
	}
}
