using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDijkstraImageContourLineInterpolator : vtkContourLineInterpolator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDijkstraImageContourLineInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkDijkstraImageContourLineInterpolator()
		{
			vtkDijkstraImageContourLineInterpolator.MRClassNameKey = "class vtkDijkstraImageContourLineInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDijkstraImageContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDijkstraImageContourLineInterpolator"));
		}

		public vtkDijkstraImageContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDijkstraImageContourLineInterpolator New()
		{
			vtkDijkstraImageContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDijkstraImageContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_GetCostImage_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetCostImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_GetCostImage_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_GetDijkstraImageGeodesicPath_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDijkstraImageGeodesicPath GetDijkstraImageGeodesicPath()
		{
			vtkDijkstraImageGeodesicPath vtkDijkstraImageGeodesicPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_GetDijkstraImageGeodesicPath_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDijkstraImageGeodesicPath = (vtkDijkstraImageGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDijkstraImageGeodesicPath.Register(null);
				}
			}
			return vtkDijkstraImageGeodesicPath;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDijkstraImageContourLineInterpolator_InterpolateLine_03(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_InterpolateLine_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDijkstraImageContourLineInterpolator_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDijkstraImageContourLineInterpolator_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDijkstraImageContourLineInterpolator NewInstance()
		{
			vtkDijkstraImageContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraImageContourLineInterpolator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDijkstraImageContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkDijkstraImageContourLineInterpolator vtkDijkstraImageContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDijkstraImageContourLineInterpolator = (vtkDijkstraImageContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDijkstraImageContourLineInterpolator.Register(null);
				}
			}
			return vtkDijkstraImageContourLineInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDijkstraImageContourLineInterpolator_SetCostImage_09(HandleRef pThis, HandleRef arg0);

		public virtual void SetCostImage(vtkImageData arg0)
		{
			vtkDijkstraImageContourLineInterpolator.vtkDijkstraImageContourLineInterpolator_SetCostImage_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
