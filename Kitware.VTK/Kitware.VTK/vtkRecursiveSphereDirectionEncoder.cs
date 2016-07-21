using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRecursiveSphereDirectionEncoder : vtkDirectionEncoder
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRecursiveSphereDirectionEncoder";

		public new static readonly string MRClassNameKey;

		static vtkRecursiveSphereDirectionEncoder()
		{
			vtkRecursiveSphereDirectionEncoder.MRClassNameKey = "class vtkRecursiveSphereDirectionEncoder";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRecursiveSphereDirectionEncoder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecursiveSphereDirectionEncoder"));
		}

		public vtkRecursiveSphereDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRecursiveSphereDirectionEncoder New()
		{
			vtkRecursiveSphereDirectionEncoder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRecursiveSphereDirectionEncoder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

		public override float[] GetDecodedGradient(int value)
		{
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetDecodedGradient_01(base.GetCppThis(), value);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

		public override IntPtr GetDecodedGradientTable()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetDecodedGradientTable_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

		public override int GetEncodedDirection(IntPtr n)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetEncodedDirection_03(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

		public override int GetNumberOfEncodedDirections()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetNumberOfEncodedDirections_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepth_05(HandleRef pThis);

		public virtual int GetRecursionDepth()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetRecursionDepth_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMaxValue_06(HandleRef pThis);

		public virtual int GetRecursionDepthMaxValue()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMinValue_07(HandleRef pThis);

		public virtual int GetRecursionDepthMinValue()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRecursiveSphereDirectionEncoder_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRecursiveSphereDirectionEncoder_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRecursiveSphereDirectionEncoder NewInstance()
		{
			vtkRecursiveSphereDirectionEncoder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRecursiveSphereDirectionEncoder SafeDownCast(vtkObjectBase o)
		{
			vtkRecursiveSphereDirectionEncoder vtkRecursiveSphereDirectionEncoder = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRecursiveSphereDirectionEncoder = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRecursiveSphereDirectionEncoder.Register(null);
				}
			}
			return vtkRecursiveSphereDirectionEncoder;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkRecursiveSphereDirectionEncoder_SetRecursionDepth_13(HandleRef pThis, int _arg);

		public virtual void SetRecursionDepth(int _arg)
		{
			vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_SetRecursionDepth_13(base.GetCppThis(), _arg);
		}
	}
}
