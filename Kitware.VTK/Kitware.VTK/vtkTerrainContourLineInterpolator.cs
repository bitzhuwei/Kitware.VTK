using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTerrainContourLineInterpolator : vtkContourLineInterpolator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTerrainContourLineInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkTerrainContourLineInterpolator()
		{
			vtkTerrainContourLineInterpolator.MRClassNameKey = "class vtkTerrainContourLineInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTerrainContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTerrainContourLineInterpolator"));
		}

		public vtkTerrainContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTerrainContourLineInterpolator New()
		{
			vtkTerrainContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTerrainContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_GetImageData_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetImageData()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_GetImageData_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTerrainContourLineInterpolator_GetProjector_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProjectedTerrainPath GetProjector()
		{
			vtkProjectedTerrainPath vtkProjectedTerrainPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_GetProjector_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTerrainPath = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTerrainPath.Register(null);
				}
			}
			return vtkProjectedTerrainPath;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainContourLineInterpolator_InterpolateLine_03(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_InterpolateLine_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainContourLineInterpolator_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainContourLineInterpolator_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTerrainContourLineInterpolator NewInstance()
		{
			vtkTerrainContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainContourLineInterpolator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTerrainContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTerrainContourLineInterpolator vtkTerrainContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTerrainContourLineInterpolator = (vtkTerrainContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTerrainContourLineInterpolator.Register(null);
				}
			}
			return vtkTerrainContourLineInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTerrainContourLineInterpolator_SetImageData_09(HandleRef pThis, HandleRef arg0);

		public virtual void SetImageData(vtkImageData arg0)
		{
			vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_SetImageData_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainContourLineInterpolator_UpdateNode_10(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkTerrainContourLineInterpolator.vtkTerrainContourLineInterpolator_UpdateNode_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}
	}
}
